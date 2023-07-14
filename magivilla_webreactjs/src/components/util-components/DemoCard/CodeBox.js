import React, { PureComponent } from "react";
import PropTypes from "prop-types";
import {Prism as SyntaxHighlighter} from 'react-syntax-highlighter';
import syntaxTheme from "./HLTheme";
import CardToolBar from './CardToolbar';

export class CodeBox extends PureComponent {
	static propTypes = {
		language: PropTypes.string
	};

	static defaultProps = {
		language: null
	};

	state = {
		codeExpand: false
	}

	exapandCallBack = () => {
		this.setState({codeExpand: !this.state.codeExpand})
	}

	render() {
		const { language, children } = this.props;
		return (
			<React.Fragment>
				<CardToolBar code={children} expand={this.exapandCallBack} isExpand={this.state.codeExpand}/>
				<div className={`code-box-highlight ${this.state.codeExpand? 'd-block':'d-none'}`} >
					<SyntaxHighlighter language={language} style={syntaxTheme}>
						{children}
					</SyntaxHighlighter>
				</div>
			</React.Fragment>
		);
	}
}

export default CodeBox;
