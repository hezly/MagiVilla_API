import { useEffect } from 'react';

const API_URL = 'https://localhost:7001/api/v1/VillaAPI';

function App() {
  const GetVillas = async () =>{
    const response = await fetch(API_URL)
    // .then((data) => {
    //   console.log(data.json());
    // }).catch(error => {
    //   console.log(error);
    // })
    ;
    const data = await response.json();
    console.log(data.result);
  }
  useEffect(() => {
    GetVillas();
  },[]);
  return (
    <div className="App">
      LOL
    </div>
  );
}

export default App;
