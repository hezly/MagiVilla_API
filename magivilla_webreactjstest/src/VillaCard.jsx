import React from 'react';

const VillaCard = ({villa}) => {
    console.log(villa)
    return (
        <div className='villa'>
            <div>
                <div>
                    <img src={villa.ImageUrl} alt='villa-img'></img>
                </div>
                <div>
                    <p>{villa.Name}</p>
                    <p>{villa.Details}</p>
                </div>
            </div>
            <div>
                <div>
                    <a >content</a>
                </div>
                <div>
                    <span >Max Occupancy : {villa.Occupancy} adults</span>
                    <br />
                    <span>Villa Size : {villa.Sqft} sqft</span>
                    <br />
                </div>
                <div>
                    <span >
                        <span >
                            {villa.Rate}
                        </span>
                    </span>
                </div>
            </div>
        </div>
    )
}

export default VillaCard;