

--ex1
SELECT dsStatus, COUNT(dsStatus) AS Quantidade
FROM tb_Status 
GROUP BY dsStatus;

-- ex1 estava com dúvida então fiz dois
SELECT tb_Processo.idStatus, COUNT(tb_Processo.idStatus)  AS quantidade, tb_Status.dsStatus
FROM tb_Processo INNER JOIN tb_Status
ON tb_Processo.idStatus = tb_Status.idStatus
GROUP BY tb_Processo.idStatus, tb_Status.dsStatus


--ex2
SELECT MAX(tb_Andamento.dtAndamento) AS maior_data from tb_Andamento
INNER JOIN tb_Processo ON tb_Processo.idProgresso = tb_Andamento.idProcesso
where tb_Processo.DtEncerramento LIKE '2013%'


-- ex3
SELECT DtEncerramento, count(DtEncerramento) as quantidade
from tb_Processo
GROUP BY DtEncerramento HAVING COUNT(DtEncerramento) > 5


--ex4
Select REPLICATE('0', 12 - LEN(nroProcesso)) + RTrim(nroProcesso) as número_de_zeros 
FROM tb_Processo 
where idProgresso = 5



