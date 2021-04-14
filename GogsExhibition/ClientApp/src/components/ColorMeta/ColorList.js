import React, { Component } from 'react';
import { ListedComponent } from '../_Listed/_ListedComponent'

export class ColorList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'colors';
    }
}
