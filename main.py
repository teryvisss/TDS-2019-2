import os, random, time

#=========== variaveis globais ========================
palavras = [

    ['S', 'a', 'l', 'a', 'm', 'e']
]

tentativas = 0
pCerta = 0
pErradas = 0
pEmJogo = None

vidas = 3
pontos = 0
limpa = "os.system('cls' if os.name == 'nt' else 'clear')"

#=========== interface ========================

def cabecalho():
    print("*==========================================*")
    print("*         JOGO DA FORCA EM PYTHON          *")
    print("*==========================================*")

def placar(pVida, pCerta, pErradas, pTentativas, pPontos):
    cabecalho()
    print("           VIDAS: "+str(pVida)+"           ")
    print("Palavras Certas: "+str(pCerta)+ "       Palavras Erradas:"+str(pErradas)+"           ")
    print("Tentativas: "+str(pTentativas)+ "            Pontos:"+str(pPontos)+"           ")
    print("*==========================================*")

#=========== Resposta Para Perguntas ========================

def pergunta(questao, erro = "Digite S para sim e N para nao"):

    while True:
        try: 
            resposta = input(questao)
            if resposta[0] == 'S' or resposta[0] =='s':
                return True
            elif resposta[0] =='N' or resposta[0] == 'n':
                return False
            else: 
                print(erro)
        except:
            print("Responda corretamente")

#============= Principal  ======================

def limparPalavras():

    palavras = [

        ['S', 'a', 'l', 'a', 'm', 'e'],

    ]

    return palavras

def gerenciadorPalavras():
    eval(limpa);
    cabecalho();

    cont, palavrasRecebidas = 0, []

    #palavras do usuario
    while True:
        cont += 1
        palavrasRecebidas += [input("Digite a " +str(cont)+"a palavra ")]

        if not pergunta("Deseja adicionar mais palavras? [S/N]: "):
            break
    
    #tratando as palavras

    palavrasTratadas, palavraTratada = [], []

    for palavra in palavrasRecebidas:
        for letra in palavra:
            palavraTratada.append(letra)

        palavrasTratadas += [palavraTratada] #cada palavra é colocada na lista 
        palavraTratada = []

    #Palavras Vazias
    palavrasVazias = 0

    if [] in palavrasTratadas:

        for palavra in palavrasTratadas:
            if palavra == []:
                palavrasVazias += 1

        #eliminando palavras vazias

        for i in range(palavrasVazias):
            for j in range(len(palavrasTratadas)):
                if palavrasTratadas[j] == []:
                    del(palavrasTratadas[j])
                    break

    return palavrasTratadas

#============ Escolhendo palavra =====================

def palavraJogo(palavras):

    return palavras[random.randint(0, len(palavras) -1)]

def quantidadeTentativas(palavraJogo):

    if len(palavraJogo) <= 4:
        tentativas = 2
    else:
         tentativas = len(palavraJogo) // random.randint(2,5)
         if tentativas <=2:
             tentativas +=2
    return tentativas

     #retornando letras certas
def letrasCertas(palavraJogo):

    palavra = []

    quantidadeLetras = len(palavraJogo) // 2

    for i in range(len(palavraJogo)):
        palavra += ['_']

    for i in range(quantidadeLetras):
        indice = random.randint(0, len(palavraJogo) -1)
        palavra[indice] = palavraJogo[indice]
    return palavra

#============ Interação com Usuario =====================
while True:

    eval(limpa);
    cabecalho();

    if pergunta("Deseja inserir mais palavras? [S/N]: "):
        #perguntar se deseja usar as palavras do jogo
        if pergunta ("Deseja usar palavras ja cadastradas? [S/N]: "):
            palavras += gerenciadorPalavras()
        else:
            palavras = gerenciadorPalavras()
            if palavras == []:
                palavras = limparPalavras()
                print("Nenhuma palavra cadastrada, será usada as padrões")
                time.sleep(3)

    iniciarJogo = True
    while iniciarJogo:
        palavra = palavraJogo(palavras)
        tentativas = quantidadeTentativas(palavra)
        palavra = letrasCertas(palavra)

        while True:
            eval(limpa);
            placar(vidas, pCerta, pErradas, tentativas, pontos);

            iniciarJogo = False
            break

    break