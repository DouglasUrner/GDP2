---
---

# Troubleshooting

This is a list of common problems that we've encountered working with Unity, C#, Rider, and Git/GitHub. Look here for solutions before asking... If the solution doesn't work for you or you encounter a problem that is not here let me know so that we can add it if it is a common problem.

## LanSchool is blocking private browsing

**Cause:** This seems to happen when you are running the Edge or Internet Explorer (IE) browsers. It may also happen if you either of those are set as your default browser.

**Solution:** Close Edge or IE if they are open. If you have no open browsers, launch Chrome and check for the "Chrome is not your default browser..." message and set your default browser to Chrome. If this does not fix the problem, please tell me so that we can track down what is happening.

## GitHub Desktop: failed "revocation" check

**Cause:** This happens when Git is unable to verify the SSL certificate of the repository server - that's a "feature" of the district firewall.

**Solution:** To work around the problem, type the following command into the **Git Bash** shell:

```bash
git config --global SSLVerify false
```

The result should be a blank line followd by Git Bash's colorful status line followed by the dollar sign ($) prompt.
