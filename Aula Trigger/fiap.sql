CREATE TABLE PRODUTO(
    CODIGO NUMBER (4),
    VALOR NUMBER(7,2)
);

INSERT INTO PRODUTO VALUES(1001, 2.55);
INSERT INTO PRODUTO VALUES(1002, 2.55);
INSERT INTO PRODUTO VALUES(1003, 2.55);

SELECT * FROM PRODUTO;

DROP TABLE valor_produto cascade constraints;

CREATE TABLE VALOR_PRODUTO(
    CODIGO NUMBER(4),
    VALOR_ANTERIOR NUMBER(7,2),
    VALOR_NOVO NUMBER(7,2));
    
select * from valor_produto;

CREATE OR REPLACE TRIGGER VERIFICA_VALOR
BEFORE UPDATE
OF VALOR
ON PRODUTO
FOR EACH ROW
BEGIN INSERT INTO VALOR_PRODUTO
VALUES
(:OLD.CODIGO, :OLD.VALOR, :NEW.VALOR);
END;


SELECT * FROM PRODUTO;
SELECT * FROM VALOR_PRODUTO;

UPDATE PRODUTO SET VALOR = 0.45 WHERE CODIGO = 1003;


-- Exercicio 

-- Suponha que voce tenha um tabela chamada funcfiap e deseje garantir que o salario
-- de um novo funcionário não seja inserido como um valor negativo.

drop table funcfiap;
create table funcFiap (mat_fun number(3) primary key,nm_fun varchar(30) not null, salareio number(10,2));

