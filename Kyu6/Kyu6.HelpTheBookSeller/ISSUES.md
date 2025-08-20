# Issues

## 1. Contradictive requirements

It declared that code order is the same in both lists.

> Note: the codes are in the same order in both lists.

But we have next example:

```
# the bookseller's stocklist:
"ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"

# list of categories: 
"A", "B", "C", "W"

# result:
"(A : 20) - (B : 114) - (C : 50) - (W : 0)"

```

*List of categories* code order is not the same as in the stocklist.

### Proposal

Return empty string, because input data doesn't complies with requirements.
