import axios from 'axios';


const axiosClient = axios.create({
    baseURL: `https://pokeapi.co/api/v2/`,
    headers: {
      'Accept': 'application/json',
      'Content-Type': 'application/json'
    }
  });


  export default {
    axiosClient
  };