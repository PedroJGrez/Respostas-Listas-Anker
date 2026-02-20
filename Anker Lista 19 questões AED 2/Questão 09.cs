// a saida seria
//2, 2, 1
//2, 3, 1
//2, 3, 3
//2, 4, 1
//2, 4, 3
//4, 4, 1

// O primeiro faz i valer 2, 4, 6 e 8. O segundo começa em j = i e só roda até 4, então ele só funciona quando i é 2 ou 4.
// O terceiro começa em 1 e vai somando o valor de i até passar de j, imprimindo os três valores a cada repetição.
// Quando i é 6 ou 8, nada acontece porque o segundo laço não executa.