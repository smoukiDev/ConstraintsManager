﻿--Select all constraint from dictionary view
SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS 
FROM ALL_CONSTRAINTS;

--Select constraints with filter
SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS 
FROM ALL_CONSTRAINTS
WHERE OWNER= {placeholder};

SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS 
FROM ALL_CONSTRAINTS
WHERE TABLE_NAME= {placeholder};

SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS 
FROM ALL_CONSTRAINTS
WHERE CONSTRAINT_NAME= {placeholder};

--Drop Constraint Statement
ALTER TABLE {placeholder_owner}.{placeholder_table} 
DROP CONSTRAINT {placeholder_constraint_name};
