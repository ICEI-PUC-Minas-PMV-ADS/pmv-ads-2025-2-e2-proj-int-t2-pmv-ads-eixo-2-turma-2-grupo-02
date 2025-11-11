// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const $sidebar = $("#agr-sidebar");
const $sidebarClose = $("#agr-sidebar-close");
const $sidebarShow = $("#agr-sidebar-show");

$sidebarClose.on("click", function () {
    $sidebar.removeClass('show');
});

$sidebarShow.on("click", function () {
    $sidebar.addClass('show');
});
function handleMaps() {
	const map = L.map('map').setView([-16.8368, -50.4056], 10);

	const tiles = L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
		maxZoom: 15,
		attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
	}).addTo(map);

	// controle que mostra info no hover
	const info = L.control();

	info.onAdd = function () {
		this._div = L.DomUtil.create('div', 'info');
		this.update();
		return this._div;
	};

	info.update = function (props) {
		const contents = props
			? `<b>${props.name}</b><br />${props.density} pessoas / km²`
			: 'Passe o mouse sobre a área';
		this._div.innerHTML = `<h4>Mil sementes/ha</h4>${contents}`;
	};

	info.addTo(map);

	// cores conforme densidade
	function getColor(d) {
		return d > 450 ? '#00EB1A' :
			d > 430 ? '#5BFF03' :
				d > 415 ? '#FBEA03' :
					d > 400 ? '#FE7E02' : '#FE0100';
	}

	function style(feature) {
		return {
			weight: 2,
			opacity: 1,
			color: 'white',
			dashArray: '3',
			fillOpacity: 0.7,
			fillColor: getColor(feature.properties.density)
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
			"density": 420
		},
		"geometry": {
			"type": "Polygon",
			"coordinates": [[
				[-50.400893, -16.832308], // topo-esquerdo
				[-50.391507, -16.832308], // topo-direito
				[-50.391507, -16.841292], // baixo-direito
				[-50.400893, -16.841292], // baixo-esquerdo
				[-50.400893, -16.832308]  // volta ao início
			]]
		}
	};

	const geojson = L.geoJson(regionData, {
		style,
		onEachFeature
	}).addTo(map);

	map.fitBounds(geojson.getBounds());

	map.attributionControl.addAttribution(
		'Dados de população fictícios &copy; IBGE'
	);

	const legend = L.control({ position: 'bottomright' });

	legend.onAdd = function () {
		const div = L.DomUtil.create('div', 'info legend');
		const grades = [450, 430, 415, 530, 400];
		const labels = [];

		for (let i = 0; i < grades.length; i++) {
			const from = grades[i];
			const to = grades[i + 1];
			const label = `${from}${to ? `–${to}` : '+'}`;
			labels.push(
				`<i style="background:${getColor(from + 1)}"></i> ${label}`
			);
		}

		labels_ = `
			<i style="background:${getColor(451)}"></i> > 450 <br/>
			<i style="background:${getColor(431)}"></i> 430 - 450 <br/>
			<i style="background:${getColor(416)}"></i> 415 - 430 <br/>
			<i style="background:${getColor(401)}"></i> 400 - 415 <br/>
			<i style="background:${getColor(400)}"></i> < 400 <br/>
		`;

		div.innerHTML = labels_;
		//div.innerHTML = labels.join('<br>');
		return div;
	};

	legend.addTo(map);
}


$(document).ready(function () {
	handleMaps();
});