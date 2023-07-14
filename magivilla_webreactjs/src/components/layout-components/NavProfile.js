import React from 'react';
import { Menu, Dropdown, Avatar } from 'antd';
import { useDispatch } from 'react-redux'
import { 
	LogoutOutlined 
} from '@ant-design/icons';
import { signOut } from 'store/slices/authSlice';

const MenuItemSignOut = (props) => (
	<span className="d-flex align-items-center">
		<LogoutOutlined className="font-size-md" />
		<span className="font-weight-normal mx-2">{props.label}</span>
	</span>
)

export const NavProfile = () => {

	const dispatch = useDispatch();

	const handleClick = ({ key }) => {
		if (key === 'Sign Out') {
			handleSignOut()
		}
	}

	const handleSignOut = () => {
		dispatch(signOut())
	}

	const menu = (
		<Menu
			onClick={handleClick}
			items={
				[
					{
						key: 'Sign Out',
						label: <MenuItemSignOut label="Sign Out" />,
					}
				]
			}
		/>
	) 

	return (
		<Dropdown placement="bottomRight" overlay={menu} trigger={["click"]}>
			<div className="nav-item">
				<div className="d-flex align-items-center">
					<Avatar src="/img/avatars/thumb-1.jpg" />
					<div className="pl-2 d-none d-sm-block profile-text">
						<div className="font-size-base font-weight-bold">Charlie Howard</div>
						<span className="opacity-0-8">Frontend Developer</span>
					</div>
				</div>
			</div>
		</Dropdown>
	);
}

export default NavProfile
