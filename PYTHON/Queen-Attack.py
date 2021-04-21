import math
def queensAttack(n, k, r_q, c_q, obstacles):
    # this code should work when only one obstacle is there per direction
    #
    #     ^
    # rows|
    #     |
    #     |
    #     |--------------> columns

    # first lets find the number of cubes the queen can attack
    # make sure to cosider the fact that array index starts from zero
    # calculate along rows
    rows_above_queen = n-r_q
    rows_below_queen = r_q-1 # these are counts not index, use < symbol for getting row index from 0
    columns_right_queen = n-c_q
    columns_left_queen = c_q-1
    diagonal_right_above = rows_above_queen
    diagonal_left_above = rows_above_queen
    diagonal_right_below=rows_below_queen
    diagonal_left_below=rows_below_queen

    # all the above 8 variables are the distance with respective items from queen's position

    # calculating the count of diagonal blocks
    if rows_above_queen != columns_right_queen:
        diagonal_right_above = min(rows_above_queen , columns_right_queen)
    if columns_left_queen !=rows_above_queen:
        diagonal_left_above = min(columns_left_queen, rows_above_queen)
    if rows_below_queen != columns_left_queen:
        diagonal_left_below =min(rows_below_queen, columns_left_queen)
    if rows_below_queen !=columns_right_queen:
        diagonal_right_below= min(rows_below_queen, columns_right_queen)
    
    # Now we have the exact number of square block in all directions of the queen, where she can attack if there is no obstructions

    print('rows_above_queen', rows_above_queen)
    print('rows_below_queen', rows_below_queen)
    print('columns_right_queen', columns_right_queen)
    print('columns_left_queen', columns_left_queen)
    print('diagonal_right_above', diagonal_right_above)
    print('diagonal_left_above', diagonal_left_above)
    print('diagonal_left_below', diagonal_left_below)
    print('diagonal_right_below', diagonal_right_below)
    print('After cosifering the obstacles')
    if k>0:
        # all this should work with only one obstacle in one direction

        # len_col_right =n
        # len_col_left =n
        # len_row_above =n
        # len_row_below =n
        # len_diag_right_above =n
        # len_diag_left_above =n
        # len_diag_right_below =n
        # len_diag_left_below =n

        for coordinate in obstacles:
            # check along rows first
            if r_q == coordinate[0]:
                # this means obstacle is on the same row as queen
                if c_q < coordinate[1] and int(math.fabs(c_q-coordinate[1]))-1 <columns_right_queen:
                    # this means obstacle is on the right of queen
                    # columns_right_queen-=n-coordinate[1]
                    
                    columns_right_queen=int(math.fabs(c_q-coordinate[1]))-1
                elif c_q>coordinate[1] and int(math.fabs(c_q-coordinate[1]))-1<columns_left_queen:
                    # columns_left_queen-=coordinate[1]
                    columns_left_queen=int(math.fabs(c_q-coordinate[1]))-1
            
            elif r_q < coordinate[0]:
                if c_q == coordinate[1] and rows_above_queen>int(math.fabs(r_q-coordinate[0]))-1:
                    # rows_above_queen-= int(math.fabs(r_q- coordinate[0]))#n-min(coordinate)
                    rows_above_queen=int(math.fabs(r_q-coordinate[0]))-1
                elif c_q<coordinate[1]:
                    if int(math.fabs(r_q-coordinate[0])) == int(math.fabs(c_q-coordinate[1])) and diagonal_right_above> int(math.fabs(r_q- coordinate[0]))-1 :
                        diagonal_right_above= int(math.fabs(r_q- coordinate[0]))-1 #n-min(coordinate)
                elif c_q>coordinate[1]:
                    if int(math.fabs(r_q-coordinate[0])) == int(math.fabs(c_q-coordinate[1])) and diagonal_left_above>int(math.fabs(r_q- coordinate[0]))-1:
                        diagonal_left_above=int(math.fabs(r_q- coordinate[0]))-1 #min(coordinate)
            else:
                if c_q== coordinate[1] and rows_below_queen> int(math.fabs(r_q-coordinate[0]))-1:
                    # rows_below_queen-= coordinate[0] # min(coordinate)
                    rows_below_queen= int(math.fabs(r_q-coordinate[0]))-1
                elif c_q> coordinate[1]:
                    if int(math.fabs(r_q-coordinate[0])) == int(math.fabs(c_q-coordinate[1])) and diagonal_left_below > int(math.fabs(r_q-coordinate[0])) -1:
                        # diagonal_left_below-=min(coordinate)
                        diagonal_left_below = int(math.fabs(r_q-coordinate[0])) -1
                elif c_q<coordinate[1]:
                    if int(math.fabs(r_q-coordinate[0])) == int(math.fabs(c_q-coordinate[1])) and diagonal_right_below > int(math.fabs(r_q-coordinate[0])) -1:
                        # diagonal_right_below-= n-min(coordinate)
                        diagonal_right_below = int(math.fabs(r_q-coordinate[0])) -1
        
    print('rows_above_queen', rows_above_queen)
    print('rows_below_queen', rows_below_queen)
    print('columns_right_queen', columns_right_queen)
    print('columns_left_queen', columns_left_queen)
    print('diagonal_right_above', diagonal_right_above)
    print('diagonal_left_above', diagonal_left_above)
    print('diagonal_left_below', diagonal_left_below)
    print('diagonal_right_below', diagonal_right_below)


    return rows_below_queen+rows_above_queen+columns_right_queen+columns_left_queen+diagonal_right_below+diagonal_right_above+diagonal_left_above+diagonal_left_below
    
    








nk=[5, 10]
r_qC_q=[4, 3]
r_q=r_qC_q[0]
c_q=r_qC_q[1]
n=nk[0]
k=nk[1]
obstacles=[[5, 5], [4, 2], [2, 3], [3, 2], [3, 4], [5, 1], [5, 3], [5, 2], [5, 4], [3, 3]]
# obstacles=[[3, 5]]

print(queensAttack(n, k, r_q, c_q, obstacles))