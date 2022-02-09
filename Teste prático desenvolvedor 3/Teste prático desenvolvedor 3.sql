-- Crie uma query que selecione todos os registros que contém “Rodr” no Nome
-- Completo e ordene os resultados pelo Documento.

SELECT CPERSON_ID, CCODE, CFULL_NAME, CDOCUMENT, CBORN_DATE FROM TPEOPLE
WHERE CFULL_NAME LIKE %Rodr%
order by CDOCUMENT;

-- Crie uma query que selecione todos os registros da tabela TPEOPLE onde a idade
-- seja maior que 20 anos.

SELECT CPERSON_ID, CCODE, CFULL_NAME, CDOCUMENT, CBORN_DATE FROM TPEOPLE
WHERE CBORN_DATE < '01-01-2002';



 
