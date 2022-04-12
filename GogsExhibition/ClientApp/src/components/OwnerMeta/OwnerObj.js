import React, { Component } from 'react';
import { ObjectComponent } from '../abstraction/ObjectComponent'

export class OwnerList extends ObjectComponent {
    constructor(prop) {
        super(prop);
        this.baseController = 'owners';
    }
}
