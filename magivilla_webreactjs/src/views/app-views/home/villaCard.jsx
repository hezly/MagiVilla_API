import React from 'react';

const VillaCard = ({villa}) => {
    return (
        <div className='ant-card ant-card-bordered ant-card-hoverable'>
            <div className='ant-card-cover'>
                <img src={villa.ImageUrl} alt='villa-img'></img>
            </div>
            <div className='ant-card-body'>
                
                <div className='ant-card-meta'>
                    <div className='ant-card-meta-title'>{villa.Name}</div>
                    <div className='ant-card-meta-description'>{villa.Details}</div>
                    <div className='ant-card-meta-description'>{villa.Occupancy}</div>
                    <div className='ant-card-meta-description'>{villa.Sqft}</div>
                </div>
            </div>
        </div>
    )
}

export default VillaCard;