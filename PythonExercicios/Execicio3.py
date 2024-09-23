import json

#
with open('json', 'r') as file:
    dados = json.load(file)

faturamento_diario = dados['faturamento_diario']


faturamento_valido = [valor for valor in faturamento_diario if valor > 0]


menor_faturamento = min(faturamento_valido)
maior_faturamento = max(faturamento_valido)


media_mensal = sum(faturamento_valido) / len(faturamento_valido)


dias_acima_da_media = sum(1 for valor in faturamento_valido if valor > media_mensal)

print(f"Menor valor de faturamento: {menor_faturamento}")
print(f"Maior valor de faturamento: {maior_faturamento}")
print(f"Número de dias com faturamento acima da média: {dias_acima_da_media}")
