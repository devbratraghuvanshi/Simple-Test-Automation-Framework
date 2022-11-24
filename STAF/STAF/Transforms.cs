namespace STAF
{
    [Binding]
	public class Transforms
	{
		[StepArgumentTransformation]
		public UserAction UserActionTransform(string userAction)
		{
			UserAction action;
			if (Enum.TryParse<UserAction>(userAction, true, out action))
			{
				return action;
			}
			else
			{
				throw new Exception(userAction + " is Not Valid User Action");
			}

		}

		[StepArgumentTransformation]
		public PageDirection PageDirectionTransform(string pageDirection)
		{
			PageDirection direction;
			if (Enum.TryParse<PageDirection>(pageDirection, true, out direction))
			{
				return direction;
				;
			}
			else
			{
				throw new Exception(pageDirection + " is Not Valid page location");
			}

		}
	}
}
