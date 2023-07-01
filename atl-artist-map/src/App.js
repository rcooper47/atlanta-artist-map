import logo from './logo.svg';
import './App.css';
import { MapContainer, TileLayer, useMap, Marker, Popup } from 'react-leaflet'
//import { Marker } from 'https://cdn.esm.sh/react-leaflet/Marker'
import { getArtists } from "./network/endpoint/artistEndPoint";
import React from 'react';
import axios from 'axios';

function App() {
  const [artists, setArtists] = React.useState(null);

  React.useEffect(() => {
    axios.get("https://pokeapi.co/api/v2/pokemon/pikachu").then((response) => {
      setArtists(response.data);
    });
  }, []);

  if (!artists) return null;

  return (
    <div className="App">
        {/* <MapContainer center={[51.505, -0.09]} zoom={13} scrollWheelZoom={false} className="map">
  <TileLayer
    attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
  />
  <Marker position={[51.505, -0.09]}>
    <Popup>
      A pretty CSS3 popup. <br /> Easily customizable.
    </Popup>
  </Marker>
</MapContainer> */}
<h1>{artists.held_items.map(item => <div>{item}</div>)}
    </h1>
    </div>
  );
}

export default App;
