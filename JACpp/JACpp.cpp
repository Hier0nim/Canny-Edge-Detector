extern "C" {
	//Author: Hieronim Daniel
	// Date: 2023
	//
	// Procedure iterates throught the row, applies 3x3 filter from the input
	// and stores the sum in output array.
	// Values in filter array are completed with zeros on each fourth element
	// void* inputArray - pointer to input array
	// void* filter - pointer to filter array
	// void* resultArray - pointer to result array
	// size - Width of the image
	_declspec(dllexport) void Calculate3x3Cpp(void* inputArray, void* filter, void* resultArray, int size)
	{
		int sum;	// initialization of the sum variable
		int j;		// initialization of the j variable
		for (int i = 0; i < size; i++)
		{
			sum = 0;
			for (j = 0; j < 3; j++)
			{
				sum += ((int*)inputArray)[i + j - size] * ((int*)filter)[j];		// Apllying filter to row above and counting sum
				sum += ((int*)inputArray)[i + j] * ((int*)filter)[j + 4];			// Apllying filter to middle row and counting sum
				sum += ((int*)inputArray)[i + j + size] * ((int*)filter)[j + 8];	// Apllying filter to row below and counting sum
			}
			((int*)resultArray)[i + 1] = sum;		// Insertion of the sum into adress from resultArray shifted by 1
		}
	}
}