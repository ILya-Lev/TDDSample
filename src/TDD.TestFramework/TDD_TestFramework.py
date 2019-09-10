class TestCase : 
	def __init__(self, name):
		self.methodUnderTheTest = name
	def run(self):
		method = getattr(self, self.methodUnderTheTest)
		method()

#was run class inherits test case class
class WasRun(TestCase) : 
	def __init__(self, name):
		self.wasRun = None
		TestCase.__init__(self, name)		#why calling base ctor is done after body of derived one?
	def testMethod(self): 
		self.wasRun = 1
	