import  axiosClient  from "../apiClient";

export function getArtists(){
    return axiosClient.get('/pokemon/ditto');
}

// export function addArtist(data){
//     return axiosClient.post('/product', JSON.stringify(data));
// }