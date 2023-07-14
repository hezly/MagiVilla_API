import { useEffect, useState } from 'react';
import VillaCard from './VillaCard';

const API_URL = 'https://localhost:7001/api/v1/VillaAPI';

function App() {
  const [villas, setVillas] = useState([]);
  const GetVillas = async () =>{
    const response = await fetch(API_URL);
    const data = await response.json();
    console.log(data.result);
    setVillas(data.result);
  }
  useEffect(() => {
    GetVillas();
  },[]);
  return (
    <div className="App">
      {
        villas?.length > 0
          ? (
            <div className='container'>
              {
                villas.map((villa) => (
                  <VillaCard villa={villa}/>
                ))
              }
            </div>
          ) : (
            <div className='empty'>
              NOT FOUND
            </div>
          )
      }
    </div>
  );
}

export default App;
