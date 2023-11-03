import React from 'react'
import { AUTH_PREFIX_PATH, APP_PREFIX_PATH } from 'configs/AppConfig'

export const publicRoutes = [
    {
        key: 'login',
        path: `${AUTH_PREFIX_PATH}/login`,
        component: React.lazy(() => import('views/auth-views/authentication/login')),
    },
    {
        key: 'register',
        path: `${AUTH_PREFIX_PATH}/register`,
        component: React.lazy(() => import('views/auth-views/authentication/register')),
    },
    {
        key: 'forgot-password',
        path: `${AUTH_PREFIX_PATH}/forgot-password`,
        component: React.lazy(() => import('views/auth-views/authentication/forgot-password')),
    }
]

export const protectedRoutes = [
    {
        key: 'dashboard.default',
        path: `${APP_PREFIX_PATH}/dashboards/default`,
        component: React.lazy(() => import('views/app-views/dashboards/default'))
    }
    ,{
        key: 'test',
        path: `${APP_PREFIX_PATH}/test`,
        component: React.lazy(() => import('views/app-views/test'))
    }
    ,{
        key: 'test.lol',
        path: `${APP_PREFIX_PATH}/test/lol/*`,
        component: React.lazy(() => import('views/app-views/test/lol'))
    }
    ,{
        key: 'home',
        path: `${APP_PREFIX_PATH}/home`,
        component: React.lazy(() => import('views/app-views/home'))
    }
    ,{
        key: 'villa',
        path: `${APP_PREFIX_PATH}/villa`,
        component: React.lazy(() => import('views/app-views/villa'))
    }
    ,{
        key: 'villa.number',
        path: `${APP_PREFIX_PATH}/villa-number`,
        component: React.lazy(() => import('views/app-views/villa-number'))
    }
]