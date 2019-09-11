class TestCase : 
	def __init__(self, name):
		self.methodUnderTheTest = name
	def run(self):
		#if hasattr(self, "setUp"):	#as TestCaseTest inherits TestCase - it does not contain the method so far
		#	settingUp = getattr(self, "setUp")
		#	settingUp()

		self.setUp()
		method = getattr(self, self.methodUnderTheTest)
		method()
		self.tearDown()

	def setUp(self): pass
	def tearDown(self): pass

#was run class inherits test case class
class WasRun(TestCase) : 
	def __init__(self, name):
		TestCase.__init__(self, name)		#why calling base ctor is done after body of derived one?
	def testMethod(self): 
		self.log += " testMethod"
	def setUp(self):
		self.log = "setUp"
	def tearDown(self):
		self.log += " tearDown"
	