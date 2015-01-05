module.exports = function (grunt) {

	// Project configuration.

	var versionNo = grunt.option('assemblyVersion') || '1.0.0.0';

	grunt.initConfig({
		// This line makes your node configurations available for use
		pkg: grunt.file.readJSON('package.json'),
		assemblyinfo: {
			options: {
				// Can be solutions, projects or individual assembly info files
				files: ['CodescapeCore.sln'],

				// Filename to search for when a solution or project is 
				// specified above. Default is AssemblyInfo.cs.
				filename: 'AssemblyInfo.cs',

				// Standard assembly info
				info: {
					company: 'Codescape Systems',
					copyright: 'Copyright Codescape Systems ' + new Date().getFullYear(),
					version: versionNo,
					fileVersion: versionNo
				}
			}
		}
	});

	grunt.loadNpmTasks('grunt-dotnet-assembly-info');


	grunt.registerTask('default', ['assemblyinfo']);
};