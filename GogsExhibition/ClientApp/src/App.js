import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { SexList } from './components/SexList';
import { ColorList } from './components/ColorList';
import { TypesShowList } from './components/TypesShowsList';
import { CountryList } from './components/CountryList';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/sex-list' component={SexList} />
                <Route path='/color-list' component={ColorList} />
                <Route path='/typeshow-list' component={TypesShowList} />
                <Route path='/country-list' component={CountryList} />
            </Layout>
        );
    }
}
