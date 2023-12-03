## Exemplo Inicial em Python

A função principal do programa Python era estruturada da seguinte maneira:

```python
def sao_isomorfos(grafo1, grafo2):
# Sua implementação aqui

# Exemplo de uso
grafo1 = {1: [2, 3], 2: [1, 3], 3: [1, 2, 4], 4: [3]}
grafo2 = {'A': ['B', 'C'], 'B': ['A', 'C'], 'C': ['A', 'B', 'D'], 'D': ['C']}
resultado = sao_isomorfos(grafo1, grafo2)
print(resultado)
```
- Neste exemplo, os grafos **grafo1** e **grafo2** são considerados **isomorfos**, e a saída esperada do programa é ```True```.
