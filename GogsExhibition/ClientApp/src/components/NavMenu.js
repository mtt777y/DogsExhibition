import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import App from '../App';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true,
            LoginSuccess: false
        };
    }

    componentDidMount() {
        App.thisNav = this;
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        let content;
        if (this.state.LoginSuccess) {
            content =
                <ul className="navbar-nav flex-grow">
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/">Home</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/sex-list">List of sexes</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/color-list">List of colors</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/typeshow-list">List of types of show</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/country-list">List of countries</NavLink>
                    </NavItem>
                </ul>

        }
        else {
            content =
                <ul className="navbar-nav flex-grow">
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/">Home</NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="text-dark" to="/loginpage">Авторизуйтесь</NavLink>
                    </NavItem>
                </ul>

        }
        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
                    <Container>
                        <NavbarBrand tag={Link} to="/">GogsExhibition</NavbarBrand>
                        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                        <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
                                {content}
                        </Collapse>
                    </Container>
                </Navbar>
            </header>
        );
    }


}
