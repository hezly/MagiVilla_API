import React, { Component, useState, useEffect } from 'react';
import InnerAppLayout from 'layouts/inner-app-layout';
import VillaItem from './villaItem';
import { Row, Col, Card, Avatar, Button } from 'antd';
import VillaCard from './villaCard';
import Flex from 'components/shared-components/Flex';

const GetVillas = () => {
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
				<Row gutter={[40, 16]} justify="space-around">
					<Col>
						<VillaCard key={villa.id} villa={villa}/>
					</Col>
				</Row>
			))
		) : (
			<div className='empty'>
				NOT FOUND
			</div>
		)
	)
}

export class Home extends Component {
	render() {
		const avatarSize = 150;
		return (
			<>
				<Row>
					<Card className='w-100 mh-100'>
						<Row>
							<img className='d-block w-100' src='/img/home/slide2.jpg' alt='slide2.jpg'></img>
						</Row>
					</Card>
				</Row>
				<Row className='w-100 mh-100'>
					<GetVillas/>
				</Row>
			</>
		)
	}
}

export default Home;
