const dev = {
  API_ENDPOINT_URL: 'https://localhost:7001/api'
//   API_ENDPOINT_URL: '/api'
};

const prod = {
  API_ENDPOINT_URL: 'https://localhost:7001/api'
};

const getEnv = () => {
	switch (process.env.NODE_ENV) {
		case 'development':
			return dev
		case 'production':
			return prod
		default:
			break;
	}
}

export const env = getEnv()
