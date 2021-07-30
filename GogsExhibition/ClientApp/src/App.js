import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { SexList } from './components/SexMeta/SexList';
import { ColorList } from './components/ColorMeta/ColorList';
import { TypesShowList } from './components/TypeShowMeta/TypesShowsList';
import { CountryList } from './components/CountryMeta/CountryList';
import { UserList } from './components/UserMeta/UserList';
import { RoleList } from './components/RoleMeta/RoleList';
import { Autorization } from './autorization/Autorization'; 

import './custom.css'

export default class App extends Component {
    static displayName = App.name;
    static token;
    static thisNav;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/sex-list' component={SexList} />
                <Route path='/color-list' component={ColorList} />
                <Route path='/typeshow-list' component={TypesShowList} />
                <Route path='/country-list' component={CountryList} />
                <Route path='/user-list' component={UserList} />
                <Route path='/role-list' component={RoleList} />
                <Route path='/loginpage' component={Autorization} />
            </Layout>
        );
    }


}
