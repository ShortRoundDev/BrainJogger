$run = {
	for($i = 0; $i -lt 10; $i++){
		.\BrainJogger.exe
	}
	echo "----"
	$confirmation = Read-Host "Run again?"
	if ($confirmation -eq 'y') {
		cls
		&$run
	}
}
&$run
