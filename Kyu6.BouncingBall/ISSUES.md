# Issues

1. It's specified that window height is smaller than initial ball height.
  Is it possible to have negative window height? Window could be located under
  the ground.
    - **Proposal**: if window height is negative, return `-1`
2. What to do if window height is zero?
    - **Proposal**: see issue 1
