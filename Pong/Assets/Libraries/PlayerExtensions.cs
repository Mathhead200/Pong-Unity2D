public static class PlayerExtensions {

	private static string[] verticalAxisNames = {
		"Vertical (Left Player)",
		"Vertical (Right Player)"
	};

	public static string getVerticalAxis(this Player player) {
		return verticalAxisNames[(int) player];
	}

}