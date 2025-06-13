# Desafio de Cálculo de Salário Líquido
Este projeto implementa um programa simples para calcular o salário líquido a ser transferido para um funcionário, considerando o valor bruto, benefícios e a dedução de imposto conforme faixas salariais específicas.

## 🚀 Desafio Proposto

Desenvolver um programa que, dado o **valor bruto do salário** e um **adicional de benefícios**, calcule e imprima o **salário final a ser transferido** para um funcionário.

O cálculo do salário a ser transferido segue a fórmula:

`(Valor Bruto do Salário - Percentual de Imposto) + Adicional dos Benefícios`

O **percentual de imposto** é determinado pelas seguintes alíquotas:

* **De R$ 0.00 a R$ 1100.00:** 5.00%
* **De R$ 1100.01 a R$ 2500.00:** 10.00%
* **Maior que R$ 2500.00:** 15.00%

## 📋 Entrada

O programa espera duas entradas sequenciais:

1.  O **valor bruto do salário**.
2.  O **valor adicional dos benefícios**.

As entradas são lidas linha a linha.

## 💡 Saída

O programa deverá gerar uma linha de saída contendo um número formatado com duas casas decimais, que representa o salário final a ser transferido ao funcionário. Este valor é o resultado da diferença entre o valor bruto do salário e o percentual de imposto aplicado, somado ao adicional dos benefícios.
