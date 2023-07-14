import React, { useState } from 'react';
import { SettingOutlined } from '@ant-design/icons';
import { Drawer } from 'antd';
import ThemeConfigurator from './ThemeConfigurator';
import { DIR_RTL } from 'constants/ThemeConstant';

export const NavPanel = ({ direction }) => {

	const [open, setOpen] = useState(false);

  	const showDrawer = () => {
		setOpen(true);
	};

  	const onClose = () => {
		setOpen(false);
	};
	
	return (
		<>
			<div className="nav-item" onClick={showDrawer}>
				<SettingOutlined className="nav-icon mr-0" />
			</div>
			<Drawer
				title="Theme Config"
				placement={direction === DIR_RTL ? 'left' : 'right'} 
				width={350}
				onClose={onClose}
				open={open}
			>
				<ThemeConfigurator/>
			</Drawer>
		</>
	)
}

export default NavPanel;