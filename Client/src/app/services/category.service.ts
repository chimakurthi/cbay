import  { Injectable } from  '@angular/core';
import { Http } from '@angular/http';
import { Category } from '../types/category';

export class CategoryService {

    private _categoriesUrl = "http://localhost/cbay.app/api/categories";
    private _categories:  Array<Category>;

    constructor(
       private  _http: Http
    ){}

    public getcategories(): Promise<Category[]>{
        return this._http.get(this._categoriesUrl)
        .toPromise()
        .then(res => { 
            this._categories = res.json() as Category[];
            return this._categories;
        })
        .catch(this.handleError);
    }

     protected handleError(error: any): Promise<any> {
		console.log('An error occurred', error);
		return Promise.reject(error);
	}
}