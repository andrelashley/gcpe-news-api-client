node('master') {

	stage('Build') {
        openshift.withCluster() {
                openshift.withProject() {
                    echo "Building..."
                    def bc = openshift.selector('bc', 'news-api-client')
                    def buildSelector = bc.startBuild()
            }
        }
    }

}
