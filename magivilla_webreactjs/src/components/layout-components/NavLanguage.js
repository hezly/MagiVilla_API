import React from "react";
import { CheckOutlined, GlobalOutlined, DownOutlined  } from '@ant-design/icons';
import { Menu, Dropdown } from "antd";
import lang from 'assets/data/language.data.json';
import { useSelector, useDispatch } from 'react-redux';
import { onLocaleChange } from 'store/slices/themeSlice';
import i18n from 'i18next'

function getLanguageDetail (locale) {
	const data = lang.filter(elm => (elm.langId === locale))
	return data[0]
}

const SelectedLanguage = () => {

	const locale = useSelector(state => state.theme.locale)

	const language = getLanguageDetail(locale);
	const {langName, icon} = language;

	return (
		<div className="d-flex align-items-center">
			<img style={{maxWidth: '20px'}} src={`/img/flags/${icon}.png`} alt={langName}/>
			<span className="font-weight-semibold ml-2">{langName} <DownOutlined className="font-size-xs"/></span>
		</div>
	)
}


const MenuItem = (props) => {
	const locale = useSelector(state => state.theme.locale);

	const dispatch = useDispatch();

	const handleLocaleChange = (langId) => {
		dispatch(onLocaleChange(langId))
		i18n.changeLanguage(langId)
	}

	return (
		<span className="d-flex justify-content-between align-items-center" onClick={() => handleLocaleChange(props.langId)}>
			<div>
				<img style={{maxWidth: '20px'}} src={`/img/flags/${props.icon}.png`} alt={props.langName}/>
				<span className="font-weight-normal ml-2">{props.langName}</span>
			</div>
			{locale === props.langId ? <CheckOutlined className="text-success" /> : null}
		</span>
	)
}

const menu = (
	<Menu 
		items={
			[
				{
					key: 'En',
					label: <MenuItem icon="us" langName="English" langId="en" />
				},
				{
					key: 'Ch',
					label: <MenuItem icon="cn" langName="Chinese" langId="zh" />
				},
				{
					key: 'Fr',
					label: <MenuItem icon="fr" langName="French" langId="fr" />
				},
				{
					key: 'Jp',
					label: <MenuItem icon="jp" langName="Janpanese" langId="ja" />
				}
			]
		}
	/>
)

export const NavLanguage = ({ configDisplay }) => {

	return (
		<Dropdown placement="bottomRight" overlay={menu} trigger={["click"]}>
			{
				configDisplay ?
				(
					<a href="#/" className="text-gray" onClick={e => e.preventDefault()}>
						<SelectedLanguage />
					</a>
				)
				:
				(
					<div className="nav-item">
						<GlobalOutlined className="nav-icon mr-0" />
					</div>
				)
			}
		</Dropdown>
	)
}

export default NavLanguage;
