pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet6'   // Ajusta al nombre configurado en Jenkins
    }

    stages {

        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                sh 'dotnet restore projectCalculadora.sln'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build projectCalculadora.sln -c Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test calculadoraApp.Tests/calculadoraApp.Tests.csproj -c Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                sh 'dotnet publish calculadoraApp/calculadoraApp.csproj -c Release -o publish --no-build'
            }
        }
    }

    post {
        success {
            archiveArtifacts artifacts: 'publish/**', fingerprint: true
        }
        failure {
            echo '❌ El pipeline falló'
        }
    }
}
