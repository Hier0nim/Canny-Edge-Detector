; Author: Hieronim Daniel
; Date: 2023
;
; Procedure iterates throught 3 rows simultaneously and 
; applies the 3x3 filter for each element of the middle row
; and stores the sum in output array.
; Values in filter array are completed with zeros on each fourth element
;
.code
Calculate3x3 proc 
    ; Parameters:
	; RCX - Adress of the input array
	; RDX - Adress of the filter array
	; R8 - Adress of the output array
	; R9 - Width ot the row

	movups xmm0, [rdx]			; Insertion of the first four dword values of filter array into xmm0 register
	movups xmm1, [rdx+16]		; Insertion of the next four dword values of filter array into xmm1 register
	movups xmm2, [rdx+32]		; Insertion of the next four dword values of filter array into xmm2 register


	xor r10, r10				; r10 register is the counter for row above, set to 0
	xor r11, r11				; r11 register is the counter, set to 0
	xor r12, r12				; r12 register is the counter for row below, set to 0

	sub	r10, r9					; Subtraction of the width from r10			
	add r12, r9					; Addition of the with to the r12 
	sub r9, 3					; Subtraction of the filter size from r10, this is the limit of the loop		

	loop1:   
		movups xmm3, [rcx + r10 * 4]	; Insertion of the four dword values from row above from input array into xmm3 register
		movups xmm4, [rcx + r11 * 4]	; Insertion of the four dword values of input array into xmm4 register
		movups xmm5, [rcx + r12 * 4]	; Insertion of the four dword values from row below from input array into xmm5 register

		vpmulld xmm3, xmm0, xmm3		; Multiplication of elements from xmm0 and xmm3 registers
		vpmulld xmm4, xmm1, xmm4		; Multiplication of elements from xmm1 and xmm4 registers
		vpmulld xmm5, xmm2, xmm5		; Multiplication of elements from xmm2 and xmm5 registers


		vpaddd	 xmm4, xmm3, xmm4		; Addition of elements from xmm3 and xmm4 registers
		vpaddd	 xmm5, xmm4, xmm5		; Addition of elements from xmm4 and xmm5 registers
		
		vphaddd	 xmm5, xmm5, xmm5		; Horizontal Addition of elements in xmm5 register
		vphaddd	 xmm5, xmm5, xmm5		; Horizontal Addition of elements in xmm5 register

		inc r11							; Incrementation of the r11 counter, also used to specify output because output adress is shifted by 1	
		movupd [r8 + r11 * 4], xmm5		; Insertion of the content from xmm5 register into adress of output array						

		inc r10							; Incrementation of the r10 counter					
		inc r12							; Incrementation of the r12 counter

        cmp r11, r9						; Comparison of the cx to the limit
        jle loop1						; Loop while less or equal

	ret							; Return
Calculate3x3 endp

Gaussian proc 

	movups xmm0, [rdx]
	movups xmm1, [rdx+16]
	movups xmm2, [rdx+32]
	movups xmm3, [rdx+48]
	movups xmm4, [rdx+64]

	mov     rax, r14
	movq	xmm11, rax

	VCVTDQ2PD xmm11, xmm11

	MOVlhPS xmm11, xmm11

	vpmovsxwd ymm0, xmm0
	vpmovsxwd ymm1, xmm1
	vpmovsxwd ymm2, xmm2
	vpmovsxwd ymm3, xmm3
	vpmovsxwd ymm4, xmm4


		xor r10, r10   ; r10-register is the counter, set to 0
		xor r11, r11   ; r11-register is the counter, set to 0
		xor r12, r12   ; r12-register is the counter, set to 0
		xor r13, r13   ; r13-register is the counter, set to 0
		xor r14, r14   ; r14-register is the counter, set to 0

		sub	r10, r9
		sub	r10, r9

		sub r11, r9

		add r13, r9

		add r14, r9
		add r14, r9

		sub r9, 5
		
		loop1: 
		;First row
		movups xmm5, [rcx + r10 * 4]
		inc r10
		movups xmm6, [rcx + r10 * 4]
		dec r10
		packssdw  xmm5, xmm6
		vpmovsxwd ymm5, xmm5

		;Second row
		movups xmm6, [rcx + r11 * 4]
		inc r11
		movups xmm7, [rcx + r11 * 4]
		dec r11
		packssdw  xmm6, xmm7
		vpmovsxwd ymm6, xmm6

		;Third row
		movups xmm7, [rcx + r12 * 4]
		inc r12
		movups xmm8, [rcx + r12 * 4]
		dec r12
		packssdw  xmm7, xmm8
		vpmovsxwd ymm7, xmm7

		;Fourth row
		movups xmm8, [rcx + r13 * 4]
		inc r13
		movups xmm9, [rcx + r13 * 4]
		dec r13
		packssdw  xmm8, xmm9
		vpmovsxwd ymm8, xmm8

		;Fifth row
		movups xmm9, [rcx + r14 * 4]
		inc r14
		movups xmm10, [rcx + r14 * 4]
		dec r14
		packssdw  xmm9, xmm10
		vpmovsxwd ymm9, xmm9


		vpmulld ymm5, ymm0, ymm5
		vpmulld ymm6, ymm1, ymm6
		vpmulld ymm7, ymm2, ymm7
		vpmulld ymm8, ymm3, ymm8
		vpmulld ymm9, ymm4, ymm9

		vpaddd	ymm6, ymm5, ymm6
		vpaddd	ymm7, ymm6, ymm7
		vpaddd	ymm8, ymm7, ymm8
		vpaddd	ymm9, ymm8, ymm9
		
		vphaddd	 ymm9, ymm9, ymm9
		vphaddd	 ymm9, ymm9, ymm9

		vpermq ymm9, ymm9, 0d8h
		VPUNPCKLDQ xmm10, xmm9, xmm9
		VPUNPCKHDQ xmm9, xmm9, xmm9

		vpaddd	xmm9, xmm10, xmm9
		CVTDQ2PD xmm9, xmm9

		DIVPD xmm9, xmm11

		CVTPD2DQ xmm9, xmm9
		MOVlhPS xmm9, xmm9

		inc r12
		inc r12
		movupd [r8 + r12 * 4], xmm9
		dec	r12
		dec	r12


		inc r10
        inc r11 
		inc r12
		inc r13
		inc r14			; Increment

        cmp r11, r9		; Compare r11 to the limit
        jle loop1		; Loop while less or equal

	ret
Gaussian endp
end 