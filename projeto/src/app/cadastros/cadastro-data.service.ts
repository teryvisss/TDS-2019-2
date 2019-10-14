import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Cadastro } from "./cadastro";

@Injectable({
  providedIn: "root"
})
export class CadastroDataService {
  constructor() {}

  private cadastrosSource = new BehaviorSubject({ cadastro: null, key: "" });
  cadastroAtual = this.cadastrosSource.asObservable();

  obtemCadastro(cadastro: Cadastro, key: string) {
    this.cadastrosSource.next({ cadastro: cadastro, key: key });
  }
}
