# Questão 2

<p>Necessitamos que você desenvolva uma aplicação que calcule a quantidade de gols marcados por time em um ano.</p>

</br>

<p>Os dados de todas as partidas são disponibilizados por uma API e podem ser filtrados passando parâmetros com os próprios campos que são retornados:</p>

</br>

<p>Método: GET</p>
<p>URL API: <a href="https://jsonmock.hackerrank.com/api/football_matches">https://jsonmock.hackerrank.com/api/football_matches</a></p>

</br>

<p>Parâmetros opcionais que podem ser utilizados:</p>
<ul>
    <li>year – int – Filtra o ano de pesquisa</li>
    <li>team1 – string – Filtra o nome do time 1 da partida</li>
    <li>team2 – string – Filtra o nome do time 2 da partida</li>
    <li>page – int – Filtra o número da página de resultados</li>
</ul>

</br>

<p>Exemplo de requisição:
<a href="https://jsonmock.hackerrank.com/api/football_matches?year=2015&team1=Galatasaray">https://jsonmock.hackerrank.com/api/football_matches?year=2015&team1=Galatasaray</a></p>

</br>

O programa deve retornar 2 resultados:

</br>

<p>Resultado 1:</p>
<p>Time: <strong>Paris Saint-Germain</strong></p>
<p>Ano: <strong>2013</strong></p>

</br>

<p>Resultado 2:</p>
<p>Time: <strong>Chelsea</strong></p>
<p>Ano: <strong>2014</strong></p>

</br>

<p>Resultado esperado:</p>
<p>Team Paris Saint - Germain scored 109 goals in 2013</p>
<p>Team Chelsea scored 92 goals in 2014</p>