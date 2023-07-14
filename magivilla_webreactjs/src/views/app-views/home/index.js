import React, { Component } from 'react';
import InnerAppLayout from 'layouts/inner-app-layout';
import VillaItem from './villaItem';

export class Home extends Component {
	render() {
		return (
			<div className="home">
				<InnerAppLayout 
					// sideContent={<MailMenu url="/app/apps/mail/" {...this.props}/>}
					mainContent={<VillaItem/>}
					border
				/>
			</div>
		)
	}
}


export default Home;
