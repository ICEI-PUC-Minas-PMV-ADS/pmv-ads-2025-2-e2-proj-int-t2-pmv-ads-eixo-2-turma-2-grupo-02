// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

/* Mobile sidebar */

const $sidebar = $("#agr-sidebar");
const $sidebarClose = $("#agr-sidebar-close");
const $sidebarShow = $("#agr-sidebar-show");

$sidebarClose.on("click", function () {
    $sidebar.removeClass('show');
});

$sidebarShow.on("click", function () {
    $sidebar.addClass('show');
});

/* Print Report */

function printReport() {
    const content = document.getElementById('agr-main-content');

    if (!content) {
        console.error('Elemento agr-main-content não encontrado');
        return;
    }

    const originalContent = document.body.innerHTML;
    const printContent = content.innerHTML;
    document.body.innerHTML = printContent;
    window.print();

    document.body.innerHTML = originalContent;
    location.reload();
}

/* Map */

let metricaAtiva = 'vigor';
let geojson = null;

function getNormalizedValue(properties) {
    switch (metricaAtiva) {
        case 'vigor': return properties.vigorPlantas;
        case 'umidade': return properties.umidade;
        case 'indice': return properties.indiceVegetativo * 100;
        default: return properties.vigorPlantas;
    }
}

function getMetricName() {
    switch (metricaAtiva) {
        case 'vigor': return 'Vigor das Plantas';
        case 'umidade': return 'Umidade do Solo';
        case 'indice': return 'Índice Vegetativo (NDVI)';
        default: return 'Vigor das Plantas';
    }
}

function formatMetricValue(value, metric) {
    switch (metric) {
        case 'vigor': return `${value}%`;
        case 'umidade': return `${value}%`;
        case 'indice': return value.toFixed(2);
        default: return `${value}%`;
    }
}
function getLegendLabels() {
    const colors = ['#00EB1A', '#5BFF03', '#FBEA03', '#FE7E02', '#FE0100'];

    if (metricaAtiva === 'indice') {
        const ranges = ['&gt; 0.80', '0.60 - 0.80', '0.40 - 0.60', '0.20 - 0.40', '&lt; 0.20'];
        return ranges.map((range, i) => `<i style="background:${colors[i]}"></i> ${range}`).join('<br/>');
    } else {
        const ranges = ['&gt; 80%', '60 - 80%', '40 - 60%', '20 - 40%', '&lt; 20%'];
        return ranges.map((range, i) => `<i style="background:${colors[i]}"></i> ${range}`).join('<br/>');
    }
}

function handleMaps() {
    const map = L.map('map').setView([-16.8368, -50.4056], 10);

    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 15,
        attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
    }).addTo(map);

    const info = L.control();

    info.onAdd = function () {
        this._div = L.DomUtil.create('div', 'info');
        this.update();
        return this._div;
    };

    info.update = function (props) {
        const contents = props
            ? `<b>${props.name}</b><br />Vigor das Plantas: ${formatMetricValue(props.vigorPlantas, 'vigor')}<br />Umidade: ${formatMetricValue(props.umidade, 'umidade')}<br />Índice Vegetativo: ${formatMetricValue(props.indiceVegetativo, 'indice')}`
            : 'Passe o mouse sobre a área';
        this._div.innerHTML = `<h4>${getMetricName()}</h4>${contents}`;
    };

    info.addTo(map);

    function getColor(d) {
        return d > 80 ? '#00EB1A' :
            d > 60 ? '#5BFF03' :
                d > 40 ? '#FBEA03' :
                    d > 20 ? '#FE7E02' : '#FE0100';
    }

    function style(feature) {
        return {
            weight: 2,
            opacity: 1,
            color: 'white',
            dashArray: '3',
            fillOpacity: 0.7,
            fillColor: getColor(getNormalizedValue(feature.properties))
        };
    }

    function highlightFeature(e) {
        const layer = e.target;
        layer.setStyle({
            weight: 4,
            color: '#666',
            dashArray: '',
            fillOpacity: 0.8
        });
        layer.bringToFront();
        info.update(layer.feature.properties);
    }

    function resetHighlight(e) {
        geojson.resetStyle(e.target);
        info.update();
    }

    function zoomToFeature(e) {
        map.fitBounds(e.target.getBounds());
    }

    function onEachFeature(feature, layer) {
        layer.on({
            mouseover: highlightFeature,
            mouseout: resetHighlight,
            click: zoomToFeature
        });
    }

    const regionData = {
        "type": "Feature",
        "properties": {
            "name": "Região de Teste - Goiás",
            "vigorPlantas": 75,
            "umidade": 50,
            "indiceVegetativo": 0.38
        },
        "geometry": {
            "type": "Polygon",
            "coordinates": [[
                [-50.400893, -16.832308],
                [-50.391507, -16.832308],
                [-50.391507, -16.841292],
                [-50.400893, -16.841292],
                [-50.400893, -16.832308]
            ]]
        }
    };

    geojson = L.geoJson(regionData, {
        style,
        onEachFeature
    }).addTo(map);

    map.fitBounds(geojson.getBounds());
    map.attributionControl.addAttribution('Dados fictícios &copy;');

    const legend = L.control({ position: 'bottomright' });

    legend.onAdd = function () {
        this._div = L.DomUtil.create('div', 'info legend');
        this.update();
        return this._div;
    };

    legend.update = function () {
        this._div.innerHTML = `<strong>${getMetricName()}</strong><br/>${getLegendLabels()}`;
    };

    legend.addTo(map);

    const metricSelector = L.control({ position: 'topright' });

    metricSelector.onAdd = function () {
        const div = L.DomUtil.create('div', 'info metric-selector');
        div.innerHTML = `
            <a href="#" data-metric="vigor" class="active">Vigor</a> | 
                <a href="#" data-metric="umidade">Umidade</a> | 
            <a href="#" data-metric="indice">Índice Veg.</a>
        `;
        return div;
    };

    metricSelector.addTo(map);

    $('.metric-selector a').on('click', function (e) {
        e.preventDefault();

        metricaAtiva = $(this).data('metric');

        $('.metric-selector a').removeClass('active');
        $(this).addClass('active');

        geojson.setStyle(style);
        legend.update();
        info.update();
    });
}

$(document).ready(function () {
    $map = $("#map");
    if ($map.length > 0) {
        handleMaps();
    }


    $('#btn-download-relatorio').on('click', function (e) {
        e.preventDefault();
        printReport();
    });
});