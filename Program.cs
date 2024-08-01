//*****************************************************************************
//** 2678. Number of Senior Citizens  leetcode                               **
//** My code was 3ms (on leetcode), below is optimized ChatGPT code          **
//** My first solutions counted 60 and above, not 61 and above.      -Dan    **
//*****************************************************************************

int countSeniors(char ** details, int detailsSize){
    int oldFarts = 0;
    for (int i = 0; i < detailsSize; i++) {
        // Directly access and convert the age substring
        int age = (details[i][11] - '0') * 10 + (details[i][12] - '0');

        // Check if the age is 61 or older
        if (age >= 61) {
            oldFarts++;
        }
            }
    return oldFarts;
}