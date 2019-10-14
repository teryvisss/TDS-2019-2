import { async } from "@angular/core/testing";
import { Injectable } from "@angular/core";
import { AngularFireDatabase } from "@angular/fire/database";
import { Cadastro } from "./cadastro";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class CadastroService {
  constructor(private _angularFireDatabase: AngularFireDatabase) {}

  insert(cadastro: Cadastro) {
    this._angularFireDatabase
      .list("cadastros")
      .push(cadastro)
      .then((result: any) => {
        console.log(result.key);
      });
  }

  update(cadastro: Cadastro, key: string) {
    this._angularFireDatabase.list("cadastros").update(key, cadastro);
  }

  /*getAll() {
    return this._angularFireDatabase.list("cadastros").snapshotChanges().pipe(map(changes =>{
      return changes.map(data => )
     }))
  }*/

  delete(key: string) {
    this._angularFireDatabase.object(`cadastros/${key}`).remove();
  }
}
