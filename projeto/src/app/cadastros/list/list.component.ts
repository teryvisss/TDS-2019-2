import { CadastroService } from "./../cadastro.service";
import { Component, OnInit } from "@angular/core";
import { CadastroDataService } from "../cadastro-data.service";
import { Observable } from "rxjs";
import { Cadastro } from "../cadastro";

@Component({
  selector: "app-list",
  templateUrl: "./list.component.html",
  styleUrls: ["./list.component.css"]
})
export class ListComponent implements OnInit {
  cadastros: Observable<any>;
  constructor(
    private _cadastroService: CadastroService,
    private _cadastroDataService: CadastroDataService
  ) {}

  ngOnInit() {
    this.cadastros = this._cadastroService.getAll();
  }

  delete(key: string) {
    this._cadastroService.delete(key);
  }

  edit(cadastro: Cadastro, key: string) {
    this._cadastroDataService.obtemCadastro(cadastro, key);
  }
}
