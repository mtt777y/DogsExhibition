import React, { Component } from 'react';
import { ObjectComponent } from '../abstraction/ObjectComponent'

export class SexList extends ObjectComponent {
    constructor(prop) {
        super(prop);
        this.baseController = 'sexes';
    }
}
