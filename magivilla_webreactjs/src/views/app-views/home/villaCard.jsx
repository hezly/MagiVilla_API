import React, { Component } from "react";
import { Card } from "antd";

// const VillaCard = ({villa}) => {
//     return (
//         <div className='ant-card ant-card-bordered ant-card-hoverable'>
//             <div className='ant-card-cover'>
//                 <img className='d-block w-100' src={villa.imageUrl} alt={villa.name}></img>
//             </div>
//             <div className='ant-card-body'>
//                 <div className='ant-card-meta'>
//                     <div className='ant-card-meta-title'>{villa.name}</div>
//                     <div className='ant-card-meta-description'>{villa.details}</div>
//                     {/* <div className='ant-card-meta-description'>{villa.occupancy}</div> */}
//                     {/* <div className='ant-card-meta-description'>{villa.sqft}</div> */}
//                 </div>
//             </div>
//         </div>
//     )
// }
const { Meta } = Card;
export class VillaCard extends Component {
    render() {
        const { villa } = this.props;
        return (
            <Card
                className="ant-card-hoverable"
                style={{ width: 300 }}
                cover={
                    <img
                    alt={villa.name}
                    src={villa.imageUrl}
                    />
                }
                // actions={[
                //     <SettingOutlined key="setting" />,
                //     <EditOutlined key="edit" />,
                //     <EllipsisOutlined key="ellipsis" />,
                // ]}
                >
                <Meta
                    title={villa.name}
                    description={villa.details}
                />
            </Card>
        );
    }
  }

export default VillaCard;