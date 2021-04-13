import React, { Component } from 'react';
import { ListedComponent } from './ListedComponent'

export class SexList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'sexes';
    }
}
