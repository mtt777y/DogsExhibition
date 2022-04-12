import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class CountryList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller, ['Flag']);
        this.baseController = 'countries';
    }
}
