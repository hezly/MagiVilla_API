import { DashboardOutlined } from '@ant-design/icons';
import { APP_PREFIX_PATH } from 'configs/AppConfig'


const dashBoardNavTree = [{
  key: 'dashboards',
  path: `${APP_PREFIX_PATH}/dashboards`,
  title: 'sidenav.dashboard',
  icon: DashboardOutlined,
  breadcrumb: false,
  isGroupTitle: false,
  submenu: [
    {
      key: 'dashboards-default',
      path: `${APP_PREFIX_PATH}/dashboards/default`,
      title: 'sidenav.dashboard.default',
      icon: DashboardOutlined,
      breadcrumb: false,
      submenu: []
    }
  ]
}]

const testNavTree = [{
  key: 'test',
  path: `${APP_PREFIX_PATH}/test`,
  title: 'test',
  icon: DashboardOutlined,
  breadcrumb: false,
  isGroupTitle: false,
  submenu: [
    // {
    //   key: 'test-lol',
    //   path: `${APP_PREFIX_PATH}/test/lol`,
    //   title: 'LOL',
    //   icon: DashboardOutlined,
    //   breadcrumb: false,
    //   submenu: []
    // }
  ]
}]

const homeNavTree = [{
  key: 'home',
  path: `${APP_PREFIX_PATH}/home`,
  title: 'home',
  icon: DashboardOutlined,
  breadcrumb: false,
  isGroupTitle: false,
  submenu: []
}]

const villaNavTree = [{
  key: 'villa',
  path: `${APP_PREFIX_PATH}/home`,
  title: 'Villa',
  icon: DashboardOutlined,
  breadcrumb: false,
  isGroupTitle: false,
  submenu: [
    {
      key: 'villa-villa',
      path: `${APP_PREFIX_PATH}/test/lol`,
      title: 'Villa',
      icon: DashboardOutlined,
      breadcrumb: false,
      submenu: []
    },
    {
      key: 'villa-number',
      path: `${APP_PREFIX_PATH}/test/lol`,
      title: 'Villa Number',
      icon: DashboardOutlined,
      breadcrumb: false,
      submenu: []
    }
  ]
}]

const navigationConfig = [
  // ...dashBoardNavTree,
  // ...testNavTree
  ...homeNavTree,
  ...villaNavTree,
]

export default navigationConfig;
