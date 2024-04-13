node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
      timeout(time: 10, unit: 'minutes'){
         withSonarQubeEnv() {
        sh "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet_8_linux/dotnet ${scannerHome}/SonarScanner.MSBuild.dll begin /k:\"dotnet2-scan\""
        sh "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet_8_linux/dotnet build"
        sh "/var/jenkins_home/tools/io.jenkins.plugins.dotnet.DotNetSDK/dotnet_8_linux/dotnet ${scannerHome}/SonarScanner.MSBuild.dll end"
      }
    }
  }
}
