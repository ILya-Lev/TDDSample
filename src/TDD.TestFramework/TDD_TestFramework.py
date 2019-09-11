class TestCase : 
	def __init__(self, name):
		self.methodUnderTheTest = name
	def run(self):
		self.setUp()
		#if hasattr(self, "setUp"):	#as TestCaseTest inherits TestCase - it does not contain the method so far
		#	settingUp = getattr(self, "setUp")
		#	settingUp()

		method = getattr(self, self.methodUnderTheTest)
		method()

	def setUp(self): pass

#was run class inherits test case class
class WasRun(TestCase) : 
	def __init__(self, name):
		TestCase.__init__(self, name)		#why calling base ctor is done after body of derived one?
	def testMethod(self): 
		self.wasRun = 1
	def setUp(self):
		self.wasRun = None
		self.wasSetUp = 1
	