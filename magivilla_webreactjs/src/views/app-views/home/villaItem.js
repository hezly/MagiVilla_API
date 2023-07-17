import React, { useState, useEffect } from 'react';
import VillaCard from './villaCard';
import { API_BASE_URL } from 'configs/AppConfig';

const VillaItem = () => {
    const [villas, setVillas] = useState([]);
    const GetVillas = async () =>{
        const response = await fetch(`https://localhost:7001/api/v1/VillaAPI`);
        const data = await response.json();
        setVillas(data.result);
        console.log(villas);
    }
    useEffect(() => {
        GetVillas();
    },[]);

    return (
        villas?.length > 0
            ? (
                villas.map((villa) => (
                    <VillaCard key={villa.id} villa={villa}/>
                  ))
            ) : (
                <div className='empty'>
                    NOT FOUND
                </div>
            )
    )
}

export default VillaItem;