import fetch from 'auth/FetchInterceptor';
import { API_BASE_URL } from 'constants/ApiConstant';

const AuthService = {}

AuthService.login = function (data) {
	return fetch({
		// url: '/auth/login',
		url: API_BASE_URL + '/v1/UserAuth/login',
		method: 'post',
		data: data
	})
}

AuthService.register = function (data) {
	return fetch({
		url: '/auth/register',
		method: 'post',
		data: data
	})
}

AuthService.logout = function () {
	return fetch({
		url: '/auth/logout',
		method: 'post'
	})
}

AuthService.loginInOAuth = function () {
	return fetch({
		url: '/auth/loginInOAuth',
		method: 'post'
	})
}

export default AuthService;