@ set modeldir=%1
@ chcp 65001 > nul
@ title Fiskmo MT engine - %1
@ spm_encode.exe --model %modeldir%\source.spm | marian-decoder.exe -c %modeldir%\decoder.yml