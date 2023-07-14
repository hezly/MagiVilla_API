import React from 'react';
import Loading from 'components/shared-components/Loading';
import { useThemeSwitcher } from 'react-css-theme-switcher';

export const AuthLayout = ({ children }) => {
	const { status } = useThemeSwitcher();

    if (status === 'loading') {
        return <Loading cover="page" />;
    }

	return (
		<div className="auth-container">
			{children}
		</div>
	)
}

export default AuthLayout
